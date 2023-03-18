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
		public override List<Ability> AvailableAbilities => new() {new Prankster(), new Infiltrator() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Chlorophyll() };
		public override Stats BaseStats => new Stats(40, 27, 60, 37, 50, 66);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Helpinghand() },
			[3] = new List<Move>() { new Fairywind() },
			[6] = new List<Move>() { new Stunspore() },
			[12] = new List<Move>() { new Megadrain() },
			[15] = new List<Move>() { new Razorleaf() },
			[18] = new List<Move>() { new Growth() },
			[21] = new List<Move>() { new Poisonpowder() },
			[24] = new List<Move>() { new Gigadrain() },
			[27] = new List<Move>() { new Charm() },
			[30] = new List<Move>() { new Leechseed() },
			[33] = new List<Move>() { new Cottonspore() },
			[36] = new List<Move>() { new Energyball() },
			[39] = new List<Move>() { new Sunnyday() },
			[42] = new List<Move>() { new Endeavor() },
			[45] = new List<Move>() { new Cottonguard() },
			[48] = new List<Move>() { new Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Beatup(), new Charm(), new Dazzlinggleam(), new Encore(), new Endure(), new Energyball(), new Facade(), new Faketears(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Mistyterrain(), new Protect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swift(), new Taunt() };
		public override List<Move> EggMoves => new List<Move>() { new Memento(), new Naturepower(), new Switcheroo(), new Tickle(), new Worryseed() };
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