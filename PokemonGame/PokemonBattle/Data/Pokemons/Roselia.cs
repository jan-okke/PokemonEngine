using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Roselia : Pokemon
	{
		public override string Name => "Roselia";
		public override List<Ability> AvailableAbilities => new() {new Naturalcure(), new Poisonpoint() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Leafguard() };
		public override Stats BaseStats => new Stats(50, 60, 45, 100, 80, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Poisonsting() },
			[1] = new List<Move>() { new Poisonsting(), new Absorb(), new Growth(), new Stunspore(), new Worryseed() },
			[5] = new List<Move>() { new Megadrain() },
			[10] = new List<Move>() { new Leechseed() },
			[15] = new List<Move>() { new Magicalleaf() },
			[20] = new List<Move>() { new Toxicspikes() },
			[25] = new List<Move>() { new Sweetscent() },
			[30] = new List<Move>() { new Gigadrain() },
			[35] = new List<Move>() { new Synthesis() },
			[40] = new List<Move>() { new Toxic() },
			[45] = new List<Move>() { new Petalblizzard() },
			[50] = new List<Move>() { new Aromatherapy() },
			[55] = new List<Move>() { new Ingrain() },
			[60] = new List<Move>() { new Petaldance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Bulletseed(), new Cut(), new Dazzlinggleam(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Hiddenpower(), new Leafstorm(), new Magicalleaf(), new Pinmissile(), new Poisonjab(), new Powerwhip(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Round(), new Seedbomb(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Spikes(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Toxic(), new Toxicspikes(), new Uproar(), new Venoshock(), new Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Cottonspore(), new Extrasensory(), new Leafstorm(), new Lifedew(), new Mindreader(), new Pinmissile(), new Powerwhip(), new Razorleaf(), new Seedbomb(), new Sleeppowder(), new Spikes(), new Synthesis() };
		public override int Weight => 20;
		public override int ExpYield => 140;
		public override int CatchRate => 150;
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