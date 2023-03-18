using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sunkern : Pokemon
	{
		public override string Name => "Sunkern";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Solarpower() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Earlybird() };
		public override Stats BaseStats => new Stats(30, 30, 30, 30, 30, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growth() },
			[4] = new List<Move>() { new Ingrain() },
			[7] = new List<Move>() { new Absorb() },
			[10] = new List<Move>() { new Megadrain() },
			[13] = new List<Move>() { new Leechseed() },
			[16] = new List<Move>() { new Razorleaf() },
			[19] = new List<Move>() { new Worryseed() },
			[22] = new List<Move>() { new Gigadrain() },
			[25] = new List<Move>() { new Endeavor() },
			[28] = new List<Move>() { new Synthesis() },
			[34] = new List<Move>() { new Solarbeam() },
			[37] = new List<Move>() { new Doubleedge() },
			[40] = new List<Move>() { new Sunnyday() },
			[43] = new List<Move>() { new Seedbomb() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Afteryou(), new Attract(), new Bulletseed(), new Confide(), new Cut(), new Doubleteam(), new Earthpower(), new Endeavor(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Lightscreen(), new Naturepower(), new Protect(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Synthesis(), new Uproar(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Curse(), new Encore(), new Grassyterrain(), new Helpinghand(), new Ingrain(), new Leechseed(), new Morningsun(), new Naturepower(), new Sweetscent() };
		public override int Weight => 18;
		public override int ExpYield => 36;
		public override int CatchRate => 235;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}