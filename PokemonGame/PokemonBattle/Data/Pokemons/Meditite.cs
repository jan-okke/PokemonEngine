using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Meditite : Pokemon
	{
		public override string Name => "Meditite";
		public override List<Ability> AvailableAbilities => new() {new Purepower() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(30, 40, 55, 60, 40, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound() },
			[4] = new List<Move>() { new Lowkick() },
			[7] = new List<Move>() { new Confusion() },
			[9] = new List<Move>() { new Detect() },
			[12] = new List<Move>() { new Endure() },
			[15] = new List<Move>() { new Feint() },
			[17] = new List<Move>() { new Forcepalm() },
			[20] = new List<Move>() { new Psybeam() },
			[23] = new List<Move>() { new Calmmind() },
			[25] = new List<Move>() { new Mindreader() },
			[28] = new List<Move>() { new Highjumpkick() },
			[31] = new List<Move>() { new Psychup() },
			[33] = new List<Move>() { new Acupressure() },
			[36] = new List<Move>() { new Powertrick() },
			[39] = new List<Move>() { new Reversal() },
			[41] = new List<Move>() { new Recover() },
			[44] = new List<Move>() { new Counter() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Bulkup(), new Calmmind(), new Confide(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Endure(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Grassknot(), new Gravity(), new Helpinghand(), new Hiddenpower(), new Icepunch(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Magiccoat(), new Painsplit(), new Poisonjab(), new Poweruppunch(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Shadowball(), new Signalbeam(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Telekinesis(), new Thunderpunch(), new Trick(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Batonpass(), new Bulletpunch(), new Dynamicpunch(), new Fakeout(), new Firepunch(), new Guardswap(), new Icepunch(), new Powerswap(), new Psychocut(), new Quickguard(), new Thunderpunch() };
		public override int Weight => 112;
		public override int ExpYield => 56;
		public override int CatchRate => 180;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}