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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Harvest() };
		public override Stats BaseStats => new Stats(60, 40, 80, 60, 45, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Absorb(), new Moves.Hypnosis() },
			[5] = new List<Move>() { new Moves.Reflect() },
			[10] = new List<Move>() { new Moves.Leechseed() },
			[15] = new List<Move>() { new Moves.Megadrain() },
			[20] = new List<Move>() { new Moves.Confusion() },
			[25] = new List<Move>() { new Moves.Synthesis() },
			[30] = new List<Move>() { new Moves.Bulletseed() },
			[35] = new List<Move>() { new Moves.Gigadrain() },
			[40] = new List<Move>() { new Moves.Extrasensory() },
			[45] = new List<Move>() { new Moves.Uproar() },
			[50] = new List<Move>() { new Moves.Worryseed() },
			[55] = new List<Move>() { new Moves.Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Energyball(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Selfdestruct(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Trickroom(), new Moves.Uproar() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Ancientpower(), new Moves.Block(), new Moves.Curse(), new Moves.Grassyterrain(), new Moves.Ingrain(), new Moves.Leafstorm(), new Moves.Moonlight(), new Moves.Naturepower(), new Moves.Poisonpowder(), new Moves.Powerswap(), new Moves.Sleeppowder(), new Moves.Stunspore(), new Moves.Synthesis() };
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