using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Giratina : Pokemon
	{
		public override string Name => "Giratina";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(150, 100, 120, 100, 120, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Shadowsneak(), new Defog() },
			[7] = new List<Move>() { new Dragonbreath() },
			[14] = new List<Move>() { new Ancientpower() },
			[21] = new List<Move>() { new Hex() },
			[28] = new List<Move>() { new Slash() },
			[35] = new List<Move>() { new Scaryface() },
			[42] = new List<Move>() { new Shadowclaw() },
			[49] = new List<Move>() { new Shadowforce() },
			[56] = new List<Move>() { new Painsplit() },
			[63] = new List<Move>() { new Aurasphere() },
			[70] = new List<Move>() { new Dragonclaw() },
			[77] = new List<Move>() { new Earthpower() },
			[84] = new List<Move>() { new Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Aurasphere(), new Bodyslam(), new Breakingswipe(), new Brutalswing(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Cut(), new Darkpulse(), new Defog(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragonpulse(), new Dreameater(), new Dualwingbeat(), new Earthpower(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Fly(), new Gigaimpact(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icywind(), new Ironhead(), new Irontail(), new Outrage(), new Painsplit(), new Payback(), new Phantomforce(), new Poltergeist(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Roar(), new Rockclimb(), new Rocksmash(), new Round(), new Safeguard(), new Scaryface(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Steelwing(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Willowisp() };
		public override int Weight => 7500;
		public override int ExpYield => 340;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}