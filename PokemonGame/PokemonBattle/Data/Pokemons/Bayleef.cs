using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bayleef : Pokemon
	{
		public override string Name => "Bayleef";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Leafguard() };
		public override Stats BaseStats => new Stats(60, 62, 80, 63, 80, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Growl(), new Razorleaf(), new Poisonpowder() },
			[6] = new List<Move>() { new Razorleaf() },
			[9] = new List<Move>() { new Poisonpowder() },
			[12] = new List<Move>() { new Synthesis() },
			[18] = new List<Move>() { new Reflect() },
			[22] = new List<Move>() { new Magicalleaf() },
			[26] = new List<Move>() { new Naturepower() },
			[32] = new List<Move>() { new Sweetscent() },
			[36] = new List<Move>() { new Lightscreen() },
			[40] = new List<Move>() { new Bodyslam() },
			[46] = new List<Move>() { new Safeguard() },
			[50] = new List<Move>() { new Aromatherapy() },
			[54] = new List<Move>() { new Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Confide(), new Cut(), new Doubleteam(), new Echoedvoice(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Hiddenpower(), new Irontail(), new Laserfocus(), new Lightscreen(), new Magiccoat(), new Naturepower(), new Protect(), new Reflect(), new Rest(), new Return(), new Rocksmash(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Workup(), new Worryseed() };
		public override int Weight => 158;
		public override int ExpYield => 142;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}