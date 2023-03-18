using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ivysaur : Pokemon
	{
		public override string Name => "Ivysaur";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Chlorophyll() };
		public override Stats BaseStats => new Stats(60, 62, 63, 60, 80, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl(), new Vinewhip(), new Growth() },
			[9] = new List<Move>() { new Leechseed() },
			[12] = new List<Move>() { new Razorleaf() },
			[15] = new List<Move>() { new Poisonpowder(), new Sleeppowder() },
			[20] = new List<Move>() { new Seedbomb() },
			[25] = new List<Move>() { new Takedown() },
			[30] = new List<Move>() { new Sweetscent() },
			[35] = new List<Move>() { new Synthesis() },
			[40] = new List<Move>() { new Worryseed() },
			[45] = new List<Move>() { new Doubleedge() },
			[50] = new List<Move>() { new Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Bodyslam(), new Bulletseed(), new Charm(), new Cut(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Flash(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Grassyglide(), new Grassyterrain(), new Helpinghand(), new Hiddenpower(), new Leafstorm(), new Lightscreen(), new Magicalleaf(), new Powerwhip(), new Protect(), new Rest(), new Rocksmash(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Toxic(), new Venoshock(), new Weatherball(), new Workup() };
		public override int Weight => 130;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}