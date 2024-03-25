using System;
using System.IO;
using System.Collections.Generic;
using Xunit;

namespace TestEditing1
{
    public class UnitTest1
    {
        [Fact]
        public void testRailwayEditing()
        {
            List<OOP_KP_2Kurs.RailwayTransport> railway = new List<OOP_KP_2Kurs.RailwayTransport>();
            railway.Add(new OOP_KP_2Kurs.RailwayTransport("Купчино", "Пушкин",
                new List<string> { "Купчино", "Пушкин" },
                new List<DateTime> { DateTime.Parse("19:55"), DateTime.Parse("19:55") }));

            bool result = OOP_KP_2Kurs.Controller.EditingRailwayTransport(int.Parse("30"), "Купчино","Пушкин",
                new List<string>{ "Купчино", "Пушкин" }, new List<DateTime> { DateTime.Parse("19:55"), 
                DateTime.Parse("19:55") },railway);
            Assert.True(result);
        }
        [Fact]

        public void TestBusEditing()
        {
            List<OOP_KP_2Kurs.Bus> bus = new List<OOP_KP_2Kurs.Bus>();
            bus.Add(new OOP_KP_2Kurs.Bus("388", 11,
                new List<string> { "Купчино", "Пушкин" }));

            bool result = OOP_KP_2Kurs.Controller.EditingBusTransport("", int.Parse("11"),
                new List<string> { "Купчино", "Пушкин" }, bus);
            Assert.True(result);
        }
        [Fact]

        public void testRiverTramEditing()
        {
            List<OOP_KP_2Kurs.RiverTram> riverTram = new List<OOP_KP_2Kurs.RiverTram>();
            riverTram.Add(new OOP_KP_2Kurs.RiverTram(DateTime.Parse("19:15"), DateTime.Parse("19:30"), "Пушкин", "Купчино"));
            bool result = OOP_KP_2Kurs.Controller.EditingRiverTram(int.Parse(""), DateTime.Parse("19:15"), 
                DateTime.Parse("19:30"), "Купчино", "Пушкин",riverTram);
            Assert.True(result);
        }
    }
}
