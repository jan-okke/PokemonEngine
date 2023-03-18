using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shroomish : Pokemon
	{
		public override string Name => "Shroomish";
		public override List<Ability> AvailableAbilities => new() {new Effectspore(), new Poisonheal() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Quickfeet() };
		public override Stats BaseStats => new Stats(60, 40, 60, 35, 40, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fluctuating;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Tackle() },
			[5] = new List<Move>() { new Stunspore() },
			[8] = new List<Move>() { new Leechseed() },
			[12] = new List<Move>() { new Megadrain() },
			[15] = new List<Move>() { new Headbutt() },
			[19] = new List<Move>() { new Poisonpowder() },
			[22] = new List<Move>() { new Worryseed() },
			[26] = new List<Move>() { new Gigadrain() },
			[29] = new List<Move>() { new Growth() },
			[33] = new List<Move>() { new Toxic() },
			[36] = new List<Move>() { new Seedbomb() },
			[40] = new List<Move>() { new Spore() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Confide(), new Doubleteam(), new Drainpunch(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Flash(), new Frustration(), new Gigadrain(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Protect(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snatch(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Synthesis(), new Toxic(), new Venoshock(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Charm(), new Faketears(), new Helpinghand(), new Seedbomb(), new Worryseed() };
		public override int Weight => 45;
		public override int ExpYield => 59;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}