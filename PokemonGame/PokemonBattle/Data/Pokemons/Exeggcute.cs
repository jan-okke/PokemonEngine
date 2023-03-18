using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Exeggcute : Pokemon
	{
		public override string Name => "Exeggcute";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Harvest() };
		public override Stats BaseStats => new Stats(60, 40, 80, 40, 60, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Hypnosis() },
			[5] = new List<Move>() { new Reflect() },
			[10] = new List<Move>() { new Leechseed() },
			[15] = new List<Move>() { new Megadrain() },
			[20] = new List<Move>() { new Confusion() },
			[25] = new List<Move>() { new Synthesis() },
			[30] = new List<Move>() { new Bulletseed() },
			[35] = new List<Move>() { new Gigadrain() },
			[40] = new List<Move>() { new Extrasensory() },
			[45] = new List<Move>() { new Uproar() },
			[50] = new List<Move>() { new Worryseed() },
			[55] = new List<Move>() { new Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Doubleteam(), new Dreameater(), new Endure(), new Energyball(), new Explosion(), new Facade(), new Flash(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Leafstorm(), new Lightscreen(), new Powerswap(), new Protect(), new Psychic(), new Psychup(), new Reflect(), new Rest(), new Round(), new Seedbomb(), new Selfdestruct(), new Skillswap(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Thief(), new Trickroom(), new Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Ancientpower(), new Block(), new Curse(), new Grassyterrain(), new Ingrain(), new Leafstorm(), new Moonlight(), new Naturepower(), new Poisonpowder(), new Powerswap(), new Sleeppowder(), new Stunspore(), new Synthesis() };
		public override int Weight => 25;
		public override int ExpYield => 65;
		public override int CatchRate => 90;
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