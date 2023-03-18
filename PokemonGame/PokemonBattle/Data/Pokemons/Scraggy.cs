using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Scraggy : Pokemon
	{
		public override string Name => "Scraggy";
		public override List<Ability> AvailableAbilities => new() {new Shedskin(), new Moxie() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Intimidate() };
		public override Stats BaseStats => new Stats(50, 75, 70, 48, 35, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Lowkick(), new Leer() },
			[4] = new List<Move>() { new Payback() },
			[8] = new List<Move>() { new Headbutt() },
			[12] = new List<Move>() { new Sandattack() },
			[16] = new List<Move>() { new Facade() },
			[20] = new List<Move>() { new Protect() },
			[24] = new List<Move>() { new Beatup() },
			[28] = new List<Move>() { new Scaryface() },
			[32] = new List<Move>() { new Brickbreak() },
			[36] = new List<Move>() { new Swagger() },
			[40] = new List<Move>() { new Crunch() },
			[44] = new List<Move>() { new Highjumpkick() },
			[48] = new List<Move>() { new Focuspunch() },
			[52] = new List<Move>() { new Headsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Assurance(), new Attract(), new Beatup(), new Brickbreak(), new Bulkup(), new Coaching(), new Crunch(), new Darkpulse(), new Dig(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Drainpunch(), new Endure(), new Facade(), new Faketears(), new Firepunch(), new Fling(), new Focusblast(), new Foulplay(), new Grassknot(), new Hiddenpower(), new Icepunch(), new Irondefense(), new Ironhead(), new Irontail(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Stoneedge(), new Substitute(), new Sunnyday(), new Taunt(), new Thief(), new Thunderpunch(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Acidspray(), new Counter(), new Detect(), new Fakeout(), new Poweruppunch(), new Quickguard() };
		public override int Weight => 118;
		public override int ExpYield => 70;
		public override int CatchRate => 180;
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