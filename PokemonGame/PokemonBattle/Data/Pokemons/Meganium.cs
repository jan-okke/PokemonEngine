using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Meganium : Pokemon
	{
		public override string Name => "Meganium";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Leafguard() };
		public override Stats BaseStats => new Stats(80, 82, 100, 80, 83, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Petaldance() },
			[1] = new List<Move>() { new Petaldance(), new Petalblizzard(), new Tackle(), new Growl(), new Razorleaf(), new Poisonpowder() },
			[6] = new List<Move>() { new Razorleaf() },
			[9] = new List<Move>() { new Poisonpowder() },
			[12] = new List<Move>() { new Synthesis() },
			[18] = new List<Move>() { new Reflect() },
			[22] = new List<Move>() { new Magicalleaf() },
			[26] = new List<Move>() { new Naturepower() },
			[34] = new List<Move>() { new Sweetscent() },
			[40] = new List<Move>() { new Lightscreen() },
			[46] = new List<Move>() { new Bodyslam() },
			[54] = new List<Move>() { new Safeguard() },
			[60] = new List<Move>() { new Aromatherapy() },
			[66] = new List<Move>() { new Solarbeam() },
			[70] = new List<Move>() { new Petalblizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulldoze(), new Bulletseed(), new Confide(), new Cut(), new Doubleteam(), new Dragontail(), new Earthquake(), new Echoedvoice(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frenzyplant(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grasspledge(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Laserfocus(), new Lightscreen(), new Magiccoat(), new Naturepower(), new Outrage(), new Protect(), new Reflect(), new Rest(), new Return(), new Rockclimb(), new Rocksmash(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Workup(), new Worryseed() };
		public override int Weight => 1005;
		public override int ExpYield => 263;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}