using FluentAssertions;
using SnowSpaceLogic;
namespace SnowSpaceTests;

public class UnitTest1
{
    [Fact]
    public void WhenRocketTakesOffItDoesNotGoBoom()
    {
        //arrange
        var rocket = new RocketShip("Ship22");

        //act
        string result = rocket.Takeoff();

        //assert
        result.Should().NotBe("Boom!");
    }

    [Fact]
    public void DoomedRocketExplodes()
    {
        //arrange
        var rocket = new RocketShip("Doomed1");

        //act
        var result = rocket.Takeoff();

        //assert
        result.Should().Be("Boom!");
    }

    [Fact]
    public void CanChangeName()
    {
        var rocket = new RocketShip("Original1");

        rocket.SetName("Changed1");

        rocket.GetName().Should().Be("Changed1");
    }

    [Fact]
    public void CannotMakeNameNull()
    {
        void makeRocketWithNullName()
        {
            var rocket = new RocketShip(null);
        }

        FluentActions
            .Invoking(makeRocketWithNullName)
            .Should()
            .Throw<Exception>();
    }

    [Fact]
    public void RocketWithNoNumberThrowsException()
    {
        void makeRocketWithoutNumber()
        {
            var rocket = new RocketShip("NoNumber");            
        }

        FluentActions
            .Invoking(makeRocketWithoutNumber)
            .Should()
            .Throw<Exception>();
    }

    [Fact]
    public void ShipCannotHaveNegativeFins()
    {
        var ship = new RocketShip("Name1");
        ship.SetNumberOfFins(-5);
        ship.GetNumberOfFins().Should().Be(0);
    }

    [Fact]
    public void ShipCanHaveThreeFins()
    {
        var ship = new RocketShip("Name1");
        ship.SetNumberOfFins(3);
        ship.GetNumberOfFins().Should().Be(3);
    }
}