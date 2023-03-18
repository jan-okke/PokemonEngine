using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cottonee : Pokemon
	{
		public override string Name => "Cottonee";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Prankster(), new Abilities.Infiltrator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Chlorophyll() };
		public override Stats BaseStats => new Stats(40, 27, 60, 37, 50, 66);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Absorb(), new Moves.Helpinghand() },
			[3] = new List<Move>() { new Moves.Fairywind() },
			[6] = new List<Move>() { new Moves.Stunspore() },
			[12] = new List<Move>() { new Moves.Megadrain() },
			[15] = new List<Move>() { new Moves.Razorleaf() },
			[18] = new List<Move>() { new Moves.Growth() },
			[21] = new List<Move>() { new Moves.Poisonpowder() },
			[24] = new List<Move>() { new Moves.Gigadrain() },
			[27] = new List<Move>() { new Moves.Charm() },
			[30] = new List<Move>() { new Moves.Leechseed() },
			[33] = new List<Move>() { new Moves.Cottonspore() },
			[36] = new List<Move>() { new Moves.Energyball() },
			[39] = new List<Move>() { new Moves.Sunnyday() },
			[42] = new List<Move>() { new Moves.Endeavor() },
			[45] = new List<Move>() { new Moves.Cottonguard() },
			[48] = new List<Move>() { new Moves.Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Beatup(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Faketears(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Mistyterrain(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Memento(), new Moves.Naturepower(), new Moves.Switcheroo(), new Moves.Tickle(), new Moves.Worryseed() };
		public override int Weight => 6;
		public override int ExpYield => 56;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}