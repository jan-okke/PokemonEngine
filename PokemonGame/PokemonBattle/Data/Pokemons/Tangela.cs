using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Tangela : Pokemon
	{
		public override string Name => "Tangela";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll(), new Abilities.Leafguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Regenerator() };
		public override Stats BaseStats => new Stats(65, 55, 115, 100, 40, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Absorb(), new Moves.Bind() },
			[4] = new List<Move>() { new Moves.Stunspore() },
			[8] = new List<Move>() { new Moves.Growth() },
			[12] = new List<Move>() { new Moves.Megadrain() },
			[16] = new List<Move>() { new Moves.Vinewhip() },
			[20] = new List<Move>() { new Moves.Poisonpowder() },
			[24] = new List<Move>() { new Moves.Ancientpower() },
			[28] = new List<Move>() { new Moves.Knockoff() },
			[32] = new List<Move>() { new Moves.Gigadrain() },
			[36] = new List<Move>() { new Moves.Sleeppowder() },
			[40] = new List<Move>() { new Moves.Slam() },
			[44] = new List<Move>() { new Moves.Tickle() },
			[48] = new List<Move>() { new Moves.Powerwhip() },
			[52] = new List<Move>() { new Moves.Ingrain() },
			[56] = new List<Move>() { new Moves.Grassyterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulletseed(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leafstorm(), new Moves.Powerswap(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Psychup(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Confusion(), new Moves.Endeavor(), new Moves.Flail(), new Moves.Leafstorm(), new Moves.Leechseed(), new Moves.Megadrain(), new Moves.Naturepower(), new Moves.Powerswap(), new Moves.Ragepowder() };
		public override int Weight => 350;
		public override int ExpYield => 87;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}