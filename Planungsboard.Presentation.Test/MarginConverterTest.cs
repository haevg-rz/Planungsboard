using System;
using System.Collections.Generic;
using FluentAssertions;
using Planungsboard.Presentation.ViewModels;
using Xunit;

namespace Planungsboard.Presentation.Test
{
    public class MarginConverterTest
    {
        [Theory]
        [InlineData("1", 0, 750)]
        [InlineData("2", 250, 500)]
        [InlineData("3", 500, 250)]
        [InlineData("4", 750, 0)]
        public void Convert_Singles(string quarter, double left, double right)
        {
            #region Arrange

            double actualWidth = 1000;
            Card card = new Card() {AssignedQuarter = new List<string>() {quarter}};
            List<string> quarters = new List<string>() {"1", "2", "3", "4"};

            #endregion

            #region Act

            var thickness = new MarginConverter().Convert(actualWidth, card, quarters);

            #endregion

            #region Assert

            thickness.Left.Should().Be(left);
            thickness.Right.Should().Be(right);

            #endregion
        }

        [Theory]
        [InlineData("1,2,3,4", 0, 0)]
        [InlineData("2,3,4", 250, 0)]
        [InlineData("1,2,3", 0, 250)]
        [InlineData("2,3", 250, 250)]
        public void Convert_Multiples(string quarter, double left, double right)
        {
            #region Arrange

            double actualWidth = 1000;
            Card card = new Card() {AssignedQuarter = new List<string>(quarter.Split(','))};
            List<string> quarters = new List<string>() {"1", "2", "3", "4"};

            #endregion

            #region Act

            var thickness = new MarginConverter().Convert(actualWidth, card, quarters);

            #endregion

            #region Assert

            thickness.Left.Should().Be(left);
            thickness.Right.Should().Be(right);

            #endregion
        }
    }
}