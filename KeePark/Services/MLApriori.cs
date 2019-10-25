﻿using Accord.MachineLearning.Rules;
using KeePark.Data;
using KeePark.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Important : In Order to use the Accord package you should download it
// through the nugget package manager and run the following commands:
// pm> Install-Package Accord -Version 3.8.2-alpha
// pm> Install-Package Accord.MachineLearning


namespace KeePark.Services
{
    public class MLApriori
    {
        private readonly KeeParkContext _context;
        // _threshold is equivelent to the support - basiclly its the amount of times an item is found in different baskets/sub-list in the matrix from the dataset
        private readonly int _threshold;
        // _confidense is an indication of how often the rule has been found true
        private readonly double _minConfidence;
        AssociationRuleMatcher<Guid> classifier = null;



        public MLApriori(KeeParkContext db)
        {
            _context = db;
            _threshold = 2;
            _minConfidence = .1;
        }
        /*
                public async Task UpdateRecommendedProductsAsync()
                {
                    await Task.Run(() =>
                    {
                        UpdateRecommendedProducts();
                    });
                }

                internal AssociationRule<int>[] GetRules()
                {
                    if (classifier == null)
                        UpdateRecommendedProducts();
                    return classifier.Rules;
                }
        */
        public void RecommendedSpots()
        {
            // First I bring the entire transactions/Reservations from the DB
            List<ReserveSpot> allReservations = _context.ReserveSpot.ToList();
            // Second I am listing whole spots shown in the entire reservations
            List<int> allUsers = new List<int>();
            List<int[]> allSpots = new List<int[]>();
            /*
            allReservations.ForEach(reserve =>
            {
                if (reserve.SpotID.ToString() != string.Empty){
                    allSpots.Add(reserve.SpotID);
                }
            });
            allSpots.ToArray();
            */
            // Apriori Algorithm is used to determine the frequent spot in the entire transactions found in the DB.
            // Create a new a-priori learning algorithm with the properties we set at the C-TOR 
            Apriori apriori = new Apriori(_threshold, _minConfidence);

            // And now we will create the learning on the array we prepared before
            //classifier = apriori.Learn(allSpots);

        }

        /*
        public List<ParkingSpot> GetRecommendedProducts(int id)
        {
            if (classifier == null)
                UpdateRecommendedProducts();
            int[][] matches = classifier.Decide(new[] { _context.Product.FirstOrDefault(x => x.ProductID == id).ProductID });

            List<int> similarItems = new List<int>();
            foreach (int[] match in matches)
            {
                foreach (int item in match)
                {
                    similarItems.Add(item);
                }
            }
            var similarIds = similarItems.ToHashSet().Take(3); // 3 most recommended items
            var test = _context.Product.Where(x => similarIds.Contains(x.ProductID));
            return test.ToList();

        }
        */
        private SortedSet<int>[] ToSortedSet(List<int>[] orders)
        {
            List<SortedSet<int>> retVal = new List<SortedSet<int>>();
            int index = 0;

            foreach (List<int> order in orders)
            {

                retVal.Add(new SortedSet<int>());
                foreach (int item in order)
                {
                    if (!retVal[index].Add(item)) // if wasnt able to add to the set then it means that the item is already existing in this transaction so we will open a new transactoin
                    {
                        index++;
                        retVal.Add(new SortedSet<int>());
                        retVal[index].Add(item);
                    }
                }
                index++;
            }
            return retVal.ToArray();
        }
    }
}