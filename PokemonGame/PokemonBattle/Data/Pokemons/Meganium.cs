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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Leafguard() };
		public override Stats BaseStats => new Stats(80, 82, 100, 83, 100, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Petaldance() },
			[1] = new List<Move>() { new Moves.Petaldance(), new Moves.Petalblizzard(), new Moves.Tackle(), new Moves.Growl(), new Moves.Razorleaf(), new Moves.Poisonpowder() },
			[6] = new List<Move>() { new Moves.Razorleaf() },
			[9] = new List<Move>() { new Moves.Poisonpowder() },
			[12] = new List<Move>() { new Moves.Synthesis() },
			[18] = new List<Move>() { new Moves.Reflect() },
			[22] = new List<Move>() { new Moves.Magicalleaf() },
			[26] = new List<Move>() { new Moves.Naturepower() },
			[34] = new List<Move>() { new Moves.Sweetscent() },
			[40] = new List<Move>() { new Moves.Lightscreen() },
			[46] = new List<Move>() { new Moves.Bodyslam() },
			[54] = new List<Move>() { new Moves.Safeguard() },
			[60] = new List<Move>() { new Moves.Aromatherapy() },
			[66] = new List<Move>() { new Moves.Solarbeam() },
			[70] = new List<Move>() { new Moves.Petalblizzard() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Dragontail(), new Moves.Earthquake(), new Moves.Echoedvoice(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Frenzyplant(), new Moves.Frustration(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Laserfocus(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Naturepower(), new Moves.Outrage(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Synthesis(), new Moves.Workup(), new Moves.Worryseed() };
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