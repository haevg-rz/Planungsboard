using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Planungsboard.Presentation.ViewModels;
using Xunit;

namespace Planungsboard.Presentation.Test
{
    public class CardsQuarterFilterForMultiplesTest
    {
        [Theory]
        [InlineData("1")]
        public void Convert_Singles_Excluded(string quarter)
        {
            #region Arrange

            var assignedQuarter = quarter.Split(',');
            Card card = new Card() {AssignedQuarter = new List<string>(assignedQuarter)};
            var quarters = new List<string>() {"1"};

            #endregion

            #region Act

            var actualCards = new CardsQuarterFilterForMultiples().Convert(new List<Card>() {card}, quarters);

            #endregion

            #region Assert

            actualCards.Should().NotContain(card);
            actualCards.Should().HaveCount(0);

            #endregion
        }

        [Theory]
        [InlineData("1,2")]
        public void Convert_Singles_Included(string quarter)
        {
            #region Arrange

            var assignedQuarter = quarter.Split(',');
            Card card = new Card() {AssignedQuarter = new List<string>(assignedQuarter)};
            var quarters = new List<string>() {"1"};

            #endregion

            #region Act

            var actualCards = new CardsQuarterFilterForMultiples().Convert(new List<Card>() {card}, quarters);

            #endregion

            #region Assert

            actualCards.Should().Contain(card);
            actualCards.Should().HaveCount(1);

            #endregion
        }

        [Theory]
        [InlineData("1,2,3", "4,5")]
        [InlineData("3,4,5", "1,2")]
        public void Convert_Multiples_Excluded(string assignedQuarterInline, string quartersInline)
        {
            #region Arrange

            var card = new Card() { AssignedQuarter = new List<string>(assignedQuarterInline.Split(',')) };
            var quarters = new List<string>(quartersInline.Split(','));

            #endregion

            #region Act

            var actualCards = new CardsQuarterFilterForMultiples().Convert(new List<Card>() { card }, quarters);

            #endregion

            #region Assert

            actualCards.Should().NotContain(card);
            actualCards.Should().HaveCount(0);

            #endregion
        }
    }
}