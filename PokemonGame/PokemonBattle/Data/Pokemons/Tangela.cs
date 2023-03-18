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
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Leafguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Regenerator() };
		public override Stats BaseStats => new Stats(65, 55, 115, 100, 40, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Bind() },
			[4] = new List<Move>() { new Stunspore() },
			[8] = new List<Move>() { new Growth() },
			[12] = new List<Move>() { new Megadrain() },
			[16] = new List<Move>() { new Vinewhip() },
			[20] = new List<Move>() { new Poisonpowder() },
			[24] = new List<Move>() { new Ancientpower() },
			[28] = new List<Move>() { new Knockoff() },
			[32] = new List<Move>() { new Gigadrain() },
			[36] = new List<Move>() { new Sleeppowder() },
			[40] = new List<Move>() { new Slam() },
			[44] = new List<Move>() { new Tickle() },
			[48] = new List<Move>() { new Powerwhip() },
			[52] = new List<Move>() { new Ingrain() },
			[56] = new List<Move>() { new Grassyterrain() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Bodyslam(), new Bulletseed(), new Cut(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Hyperbeam(), new Leafstorm(), new Powerswap(), new Powerwhip(), new Protect(), new Psychup(), new Reflect(), new Rest(), new Rocksmash(), new Round(), new Seedbomb(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Thief() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Confusion(), new Endeavor(), new Flail(), new Leafstorm(), new Leechseed(), new Megadrain(), new Naturepower(), new Powerswap(), new Ragepowder() };
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