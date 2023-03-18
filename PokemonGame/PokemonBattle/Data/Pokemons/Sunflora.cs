using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sunflora : Pokemon
	{
		public override string Name => "Sunflora";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Solarpower() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Earlybird() };
		public override Stats BaseStats => new Stats(75, 75, 55, 105, 85, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Flowershield(), new Moves.Pound(), new Moves.Growth() },
			[4] = new List<Move>() { new Moves.Ingrain() },
			[7] = new List<Move>() { new Moves.Absorb() },
			[10] = new List<Move>() { new Moves.Megadrain() },
			[13] = new List<Move>() { new Moves.Leechseed() },
			[16] = new List<Move>() { new Moves.Razorleaf() },
			[19] = new List<Move>() { new Moves.Worryseed() },
			[22] = new List<Move>() { new Moves.Gigadrain() },
			[25] = new List<Move>() { new Moves.Bulletseed() },
			[28] = new List<Move>() { new Moves.Petaldance() },
			[34] = new List<Move>() { new Moves.Solarbeam() },
			[37] = new List<Move>() { new Moves.Doubleedge() },
			[40] = new List<Move>() { new Moves.Sunnyday() },
			[43] = new List<Move>() { new Moves.Leafstorm() },
			[50] = new List<Move>() { new Moves.Petalblizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Afteryou(), new Moves.Attract(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Naturepower(), new Moves.Protect(), new Moves.Rest(), new Moves.Return(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Uproar(), new Moves.Worryseed() };
		public override int Weight => 85;
		public override int ExpYield => 149;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}