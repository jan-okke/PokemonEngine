using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lillipup : Pokemon
	{
		public override string Name => "Lillipup";
		public override List<Ability> AvailableAbilities => new() {new Vitalspirit(), new Pickup() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Runaway() };
		public override Stats BaseStats => new Stats(45, 60, 45, 25, 45, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer() },
			[4] = new List<Move>() { new Workup() },
			[8] = new List<Move>() { new Bite() },
			[12] = new List<Move>() { new Retaliate() },
			[17] = new List<Move>() { new Babydolleyes() },
			[20] = new List<Move>() { new Playrough() },
			[24] = new List<Move>() { new Crunch() },
			[28] = new List<Move>() { new Takedown() },
			[32] = new List<Move>() { new Helpinghand() },
			[36] = new List<Move>() { new Reversal() },
			[40] = new List<Move>() { new Roar() },
			[44] = new List<Move>() { new Lastresort() },
			[48] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Charm(), new Crunch(), new Dig(), new Endure(), new Facade(), new Firefang(), new Gigaimpact(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icefang(), new Payback(), new Playrough(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Retaliate(), new Reversal(), new Rocktomb(), new Round(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Sunnyday(), new Thunderbolt(), new Thunderfang(), new Thunderwave(), new Uproar(), new Wildcharge(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Afteryou(), new Covet(), new Howl(), new Lick(), new Mudslap(), new Yawn() };
		public override int Weight => 41;
		public override int ExpYield => 55;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}