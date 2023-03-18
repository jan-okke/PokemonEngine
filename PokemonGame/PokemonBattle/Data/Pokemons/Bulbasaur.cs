using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bulbasaur : Pokemon
	{
		public override string Name => "Bulbasaur";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Chlorophyll() };
		public override Stats BaseStats => new Stats(45, 49, 49, 65, 65, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Growl() },
			[3] = new List<Move>() { new Moves.Vinewhip() },
			[6] = new List<Move>() { new Moves.Growth() },
			[9] = new List<Move>() { new Moves.Leechseed() },
			[12] = new List<Move>() { new Moves.Razorleaf() },
			[15] = new List<Move>() { new Moves.Poisonpowder(), new Moves.Sleeppowder() },
			[18] = new List<Move>() { new Moves.Seedbomb() },
			[21] = new List<Move>() { new Moves.Takedown() },
			[24] = new List<Move>() { new Moves.Sweetscent() },
			[27] = new List<Move>() { new Moves.Synthesis() },
			[30] = new List<Move>() { new Moves.Worryseed() },
			[33] = new List<Move>() { new Moves.Doubleedge() },
			[36] = new List<Move>() { new Moves.Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bulletseed(), new Moves.Charm(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Toxic(), new Moves.Venoshock(), new Moves.Weatherball(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Charm(), new Moves.Curse(), new Moves.Grassyterrain(), new Moves.Ingrain(), new Moves.Leafstorm(), new Moves.Magicalleaf(), new Moves.Naturepower(), new Moves.Petaldance(), new Moves.Powerwhip(), new Moves.Skullbash(), new Moves.Sludge() };
		public override int Weight => 69;
		public override int ExpYield => 64;
		public override int CatchRate => 45;
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