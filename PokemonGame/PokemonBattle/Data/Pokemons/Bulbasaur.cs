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
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Chlorophyll() };
		public override Stats BaseStats => new Stats(45, 49, 49, 65, 65, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl() },
			[3] = new List<Move>() { new Vinewhip() },
			[6] = new List<Move>() { new Growth() },
			[9] = new List<Move>() { new Leechseed() },
			[12] = new List<Move>() { new Razorleaf() },
			[15] = new List<Move>() { new Poisonpowder(), new Sleeppowder() },
			[18] = new List<Move>() { new Seedbomb() },
			[21] = new List<Move>() { new Takedown() },
			[24] = new List<Move>() { new Sweetscent() },
			[27] = new List<Move>() { new Synthesis() },
			[30] = new List<Move>() { new Worryseed() },
			[33] = new List<Move>() { new Doubleedge() },
			[36] = new List<Move>() { new Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Bodyslam(), new Bulletseed(), new Charm(), new Cut(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Flash(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Leafstorm(), new Lightscreen(), new Magicalleaf(), new Powerwhip(), new Protect(), new Rest(), new Rocksmash(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Toxic(), new Venoshock(), new Weatherball(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Charm(), new Curse(), new Grassyterrain(), new Ingrain(), new Leafstorm(), new Magicalleaf(), new Naturepower(), new Petaldance(), new Powerwhip(), new Skullbash(), new Sludge() };
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