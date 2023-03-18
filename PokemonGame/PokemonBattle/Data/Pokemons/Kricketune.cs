using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Kricketune : Pokemon
	{
		public override string Name => "Kricketune";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Technician() };
		public override Stats BaseStats => new Stats(77, 85, 51, 55, 51, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Furycutter() },
			[1] = new List<Move>() { new Moves.Furycutter(), new Moves.Growl(), new Moves.Pound() },
			[14] = new List<Move>() { new Moves.Absorb() },
			[18] = new List<Move>() { new Moves.Sing() },
			[22] = new List<Move>() { new Moves.Focusenergy() },
			[26] = new List<Move>() { new Moves.Slash() },
			[30] = new List<Move>() { new Moves.Xscissor() },
			[34] = new List<Move>() { new Moves.Screech() },
			[36] = new List<Move>() { new Moves.Fellstinger() },
			[38] = new List<Move>() { new Moves.Taunt() },
			[42] = new List<Move>() { new Moves.Nightslash() },
			[44] = new List<Move>() { new Moves.Stickyweb() },
			[46] = new List<Move>() { new Moves.Bugbuzz() },
			[50] = new List<Move>() { new Moves.Perishsong() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bugbite(), new Moves.Bugbuzz(), new Moves.Confide(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Echoedvoice(), new Moves.Endeavor(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Flash(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Healbell(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Infestation(), new Moves.Knockoff(), new Moves.Laserfocus(), new Moves.Leechlife(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Throatchop(), new Moves.Uproar(), new Moves.Xscissor() };
		public override int Weight => 255;
		public override int ExpYield => 134;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}