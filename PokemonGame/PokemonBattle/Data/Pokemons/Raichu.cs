using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Raichu : Pokemon
	{
		public override string Name => "Raichu";
		public override List<Ability> AvailableAbilities => new() {new Static() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Lightningrod() };
		public override Stats BaseStats => new Stats(60, 90, 55, 110, 90, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Electric };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Thunderpunch() },
			[1] = new List<Move>() { new Thunderpunch(), new Playnice(), new Sweetkiss(), new Nuzzle(), new Nastyplot(), new Charm(), new Thunderwave(), new Doubleteam(), new Electroball(), new Feint(), new Spark(), new Agility(), new Slam(), new Discharge(), new Thunderbolt(), new Lightscreen(), new Thunder(), new Thundershock(), new Tailwhip(), new Growl(), new Quickattack() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Chargebeam(), new Charm(), new Dig(), new Doubleteam(), new Drainingkiss(), new Eerieimpulse(), new Electricterrain(), new Electroball(), new Electroweb(), new Encore(), new Endure(), new Facade(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Lightscreen(), new Megakick(), new Megapunch(), new Nastyplot(), new Payday(), new Playrough(), new Protect(), new Raindance(), new Reflect(), new Rest(), new Reversal(), new Risingvoltage(), new Rocksmash(), new Round(), new Safeguard(), new Shockwave(), new Sleeptalk(), new Snore(), new Speedswap(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Thief(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uproar(), new Voltswitch(), new Wildcharge() };
		public override int Weight => 300;
		public override int ExpYield => 243;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 3
		};
	}
}