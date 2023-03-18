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
		public override List<Ability> AvailableAbilities => new() {new Swarm() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Technician() };
		public override Stats BaseStats => new Stats(77, 85, 51, 65, 55, 51);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Furycutter() },
			[1] = new List<Move>() { new Furycutter(), new Growl(), new Pound() },
			[14] = new List<Move>() { new Absorb() },
			[18] = new List<Move>() { new Sing() },
			[22] = new List<Move>() { new Focusenergy() },
			[26] = new List<Move>() { new Slash() },
			[30] = new List<Move>() { new Xscissor() },
			[34] = new List<Move>() { new Screech() },
			[36] = new List<Move>() { new Fellstinger() },
			[38] = new List<Move>() { new Taunt() },
			[42] = new List<Move>() { new Nightslash() },
			[44] = new List<Move>() { new Stickyweb() },
			[46] = new List<Move>() { new Bugbuzz() },
			[50] = new List<Move>() { new Perishsong() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Brickbreak(), new Bugbite(), new Bugbuzz(), new Confide(), new Cut(), new Doubleteam(), new Echoedvoice(), new Endeavor(), new Endure(), new Facade(), new Falseswipe(), new Flash(), new Frustration(), new Gigaimpact(), new Healbell(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Infestation(), new Knockoff(), new Laserfocus(), new Leechlife(), new Poweruppunch(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Sleeptalk(), new Snore(), new Strength(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Taunt(), new Throatchop(), new Uproar(), new Xscissor() };
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