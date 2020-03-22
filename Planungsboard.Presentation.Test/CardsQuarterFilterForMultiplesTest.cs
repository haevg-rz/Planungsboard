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

            var quarterList = quarter.Split(',');
            Card card = new Card() {AssignedQuarter = new List<string>(quarterList)};

            #endregion

            #region Act

            var actualCards = new CardsQuarterFilterForMultiples().Convert(new List<Card>() {card});

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

            var quarterList = quarter.Split(',');
            Card card = new Card() {AssignedQuarter = new List<string>(quarterList)};

            #endregion

            #region Act

            var actualCards = new CardsQuarterFilterForMultiples().Convert(new List<Card>() {card});

            #endregion

            #region Assert

            actualCards.Should().Contain(card);
            actualCards.Should().HaveCount(1);

            #endregion
        }
    }
}