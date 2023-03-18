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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
		public override Stats BaseStats => new Stats(150, 100, 120, 100, 120, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Shadowsneak(), new Moves.Defog() },
			[7] = new List<Move>() { new Moves.Dragonbreath() },
			[14] = new List<Move>() { new Moves.Ancientpower() },
			[21] = new List<Move>() { new Moves.Hex() },
			[28] = new List<Move>() { new Moves.Slash() },
			[35] = new List<Move>() { new Moves.Scaryface() },
			[42] = new List<Move>() { new Moves.Shadowclaw() },
			[49] = new List<Move>() { new Moves.Shadowforce() },
			[56] = new List<Move>() { new Moves.Painsplit() },
			[63] = new List<Move>() { new Moves.Aurasphere() },
			[70] = new List<Move>() { new Moves.Dragonclaw() },
			[77] = new List<Move>() { new Moves.Earthpower() },
			[84] = new List<Move>() { new Moves.Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Aurasphere(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Outrage(), new Moves.Painsplit(), new Moves.Payback(), new Moves.Phantomforce(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaryface(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Steelwing(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Willowisp() };
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