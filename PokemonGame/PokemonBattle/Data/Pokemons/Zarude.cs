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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Leafguard() };
		public override Stats BaseStats => new Stats(105, 120, 105, 70, 95, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Bind(), new Moves.Scratch() },
			[6] = new List<Move>() { new Moves.Leer() },
			[12] = new List<Move>() { new Moves.Vinewhip() },
			[18] = new List<Move>() { new Moves.Growth() },
			[24] = new List<Move>() { new Moves.Furyswipes() },
			[30] = new List<Move>() { new Moves.Scaryface() },
			[36] = new List<Move>() { new Moves.Grassknot() },
			[42] = new List<Move>() { new Moves.Bite() },
			[48] = new List<Move>() { new Moves.Uturn() },
			[54] = new List<Move>() { new Moves.Swagger() },
			[60] = new List<Move>() { new Moves.Energyball() },
			[66] = new List<Move>() { new Moves.Synthesis() },
			[72] = new List<Move>() { new Moves.Hammerarm() },
			[78] = new List<Move>() { new Moves.Thrash() },
			[84] = new List<Move>() { new Moves.Powerwhip() },
			[90] = new List<Move>() { new Moves.Junglehealing() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Assurance(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulletseed(), new Moves.Closecombat(), new Moves.Crunch(), new Moves.Darkestlariat(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Drainpunch(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Magicalleaf(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mudshot(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Uturn() };
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