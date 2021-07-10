using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Unity.PerformanceTesting;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Haha
    {
        // A Test behaves as an ordinary method
        [Test, Performance]
        public void HahaSimplePasses()
        {
            Measure
                .Method(() =>
                {
                    // Use the Assert class to test conditions
                    Assert.True(true);
                })
                .WarmupCount(100)
                .MeasurementCount(1000000)
                .Run();
        }
    }
}
