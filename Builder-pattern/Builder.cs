using Builder_pattern.car_values;

namespace Builder_pattern
{
    public interface IBuilder
    {
        public Engine BuildEngine(int hp, string name, string company);
        public Door BuildDoors();
        public Seat BuildSeats();
        public Well BuildWells(int radius, string name, string material);
    }

    public abstract class Builder : IBuilder
    {
        public abstract Engine BuildEngine(int hp, string name, string company);

        public abstract Door BuildDoors();

        public abstract Seat BuildSeats();

        public abstract Well BuildWells(int radius, string name, string material);
    }

    public class BmwBuilder : Builder
    {
        public override Engine BuildEngine(int hp, string name, string company) => new Engine(hp, name, company);
        public override Door BuildDoors() => new Door();

        public override Seat BuildSeats() => new Seat();
        public override Well BuildWells(int radius, string name, string material) => new Well(radius, name, material);
    }

    public class MercedesBuilder : Builder
    {
        public override Engine BuildEngine(int hp, string name, string company) => new Engine(hp, name, company);
        public override Door BuildDoors() => new Door();
        public override Seat BuildSeats() => new Seat();
        public override Well BuildWells(int radius, string name, string material) => new Well(radius, name, material);
    }

    public class AudiBuilder : Builder
    {
        public override Engine BuildEngine(int hp, string name, string company) => new Engine(hp, name, company);
        public override Door BuildDoors() => new Door();
        public override Seat BuildSeats() => new Seat();
        public override Well BuildWells(int radius, string name, string material) => new Well(radius, name, material);
    } 
}