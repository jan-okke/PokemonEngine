using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Zarude : Pokemon
	{
		public override string Name => "Zarude";
		public override List<Ability> AvailableAbilities => new() {new Leafguard() };
		public override Stats BaseStats => new Stats(105, 120, 105, 70, 95, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Bind(), new Scratch() },
			[6] = new List<Move>() { new Leer() },
			[12] = new List<Move>() { new Vinewhip() },
			[18] = new List<Move>() { new Growth() },
			[24] = new List<Move>() { new Furyswipes() },
			[30] = new List<Move>() { new Scaryface() },
			[36] = new List<Move>() { new Grassknot() },
			[42] = new List<Move>() { new Bite() },
			[48] = new List<Move>() { new Uturn() },
			[54] = new List<Move>() { new Swagger() },
			[60] = new List<Move>() { new Energyball() },
			[66] = new List<Move>() { new Synthesis() },
			[72] = new List<Move>() { new Hammerarm() },
			[78] = new List<Move>() { new Thrash() },
			[84] = new List<Move>() { new Powerwhip() },
			[90] = new List<Move>() { new Junglehealing() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Assurance(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulletseed(), new Closecombat(), new Crunch(), new Darkestlariat(), new Darkpulse(), new Dig(), new Drainpunch(), new Encore(), new Endure(), new Energyball(), new Facade(), new Fling(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irontail(), new Lashout(), new Lowkick(), new Magicalleaf(), new Megakick(), new Megapunch(), new Mudshot(), new Nastyplot(), new Payback(), new Powerwhip(), new Protect(), new Rest(), new Revenge(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Seedbomb(), new Sleeptalk(), new Snarl(), new Snore(), new Solarbeam(), new Solarblade(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Superpower(), new Swift(), new Taunt(), new Thief(), new Throatchop(), new Uturn() };
		public override int Weight => 700;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}