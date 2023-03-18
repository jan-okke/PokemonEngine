using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Budew : Pokemon
	{
		public override string Name => "Budew";
		public override List<Ability> AvailableAbilities => new() {new Naturalcure(), new Poisonpoint() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Leafguard() };
		public override Stats BaseStats => new Stats(40, 30, 35, 55, 50, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Growth(), new Stunspore(), new Worryseed() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Cut(), new Dazzlinggleam(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Hiddenpower(), new Leafstorm(), new Pinmissile(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Round(), new Seedbomb(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Spikes(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Uproar(), new Venoshock(), new Weatherball() };
		public override List<Move> EggMoves => new List<Move>() { new Cottonspore(), new Extrasensory(), new Leafstorm(), new Lifedew(), new Mindreader(), new Pinmissile(), new Razorleaf(), new Seedbomb(), new Sleeppowder(), new Spikes(), new Synthesis() };
		public override int Weight => 12;
		public override int ExpYield => 56;
		public override int CatchRate => 255;
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