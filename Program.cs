using System;
using System.Collections.Generic;
using Amazon.Cloudwatch;
using Amazon.Cloudwatch.Model;


namespace cwtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new AmazonCloudWatchClient();

            var dimension = new Dimension
            {
                Name = "Desktop Machine Metrics",
                Value = "Virtual Desktop Machine Usage"
            };

            var metric1 = new MetricDatum
            {
                Dimensions = new List<dimension>(),
                MetricName = "Desktop Machines Online",
                StatisticValues = new StatisticSet(),
                Timestamp = DateTime.Today,
                Unit = StandardUnit.Count,
                Value = 14
            };

            var metric2 = new MetricDatum
            {
                Dimensions = new List<dimension>(),
                MetricName = "Desktop Machines Offline",
                StatisticValues = new StatisticSet(),
                Timestamp = DateTime.Today,
                Unit = StandardUnit.Count,
                Value = 7
            };

            var metric3 = new MetricDatum
            {
                Dimensions = new List<dimension>(),
                MetricName = "Desktop Machines Online",
                StatisticValues = new StatisticSet(),
                Timestamp = DateTime.Today,
                Unit = StandardUnit.Count,
                Value = 12
            };

            var metric4 = new MetricDatum
            {
                Dimensions = new List<dimension>(),
                MetricName = "Desktop Machines Offline",
                StatisticValues = new StatisticSet(),
                Timestamp = DateTime.Today,
                Unit = StandardUnit.Count,
                Value = 9
            };

            var request = new PutMetricDataRequest
            {
                MetricData = new List<metricdatum>() { metric1, metric2,
    metric3, metric4 },
                Namespace = "Example.com Custom Metrics"
            };

            client.PutMetricData(request);
        }
    }
}
