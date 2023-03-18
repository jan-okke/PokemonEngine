using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Darkrai : Pokemon
	{
		public override string Name => "Darkrai";
		public override List<Ability> AvailableAbilities => new() {new Baddreams() };
		public override Stats BaseStats => new Stats(70, 90, 90, 135, 90, 125);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Confuseray(), new Disable() },
			[11] = new List<Move>() { new Quickattack() },
			[20] = new List<Move>() { new Hypnosis() },
			[29] = new List<Move>() { new Suckerpunch() },
			[38] = new List<Move>() { new Foulplay() },
			[47] = new List<Move>() { new Doubleteam() },
			[57] = new List<Move>() { new Haze() },
			[66] = new List<Move>() { new Darkvoid() },
			[75] = new List<Move>() { new Nastyplot() },
			[84] = new List<Move>() { new Dreameater() },
			[93] = new List<Move>() { new Darkpulse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Blizzard(), new Brickbreak(), new Calmmind(), new Chargebeam(), new Confide(), new Cut(), new Darkpulse(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Embargo(), new Endure(), new Facade(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Foulplay(), new Frustration(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Knockoff(), new Lastresort(), new Nastyplot(), new Payback(), new Poisonjab(), new Poweruppunch(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Return(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snatch(), new Snore(), new Spite(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Taunt(), new Thief(), new Throatchop(), new Thunder(), new Thunderbolt(), new Thunderwave(), new Torment(), new Trick(), new Willowisp(), new Wonderroom(), new Xscissor() };
		public override int Weight => 505;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}