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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Baddreams() };
		public override Stats BaseStats => new Stats(70, 90, 90, 135, 90, 125);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dark };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Confuseray(), new Moves.Disable() },
			[11] = new List<Move>() { new Moves.Quickattack() },
			[20] = new List<Move>() { new Moves.Hypnosis() },
			[29] = new List<Move>() { new Moves.Suckerpunch() },
			[38] = new List<Move>() { new Moves.Foulplay() },
			[47] = new List<Move>() { new Moves.Doubleteam() },
			[57] = new List<Move>() { new Moves.Haze() },
			[66] = new List<Move>() { new Moves.Darkvoid() },
			[75] = new List<Move>() { new Moves.Nastyplot() },
			[84] = new List<Move>() { new Moves.Dreameater() },
			[93] = new List<Move>() { new Moves.Darkpulse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Blizzard(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Embargo(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Foulplay(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Knockoff(), new Moves.Lastresort(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockclimb(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snatch(), new Moves.Snore(), new Moves.Spite(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Willowisp(), new Moves.Wonderroom(), new Moves.Xscissor() };
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