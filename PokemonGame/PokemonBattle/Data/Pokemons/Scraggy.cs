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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Shedskin(), new Abilities.Moxie() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Intimidate() };
		public override Stats BaseStats => new Stats(50, 75, 70, 35, 70, 48);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Lowkick(), new Moves.Leer() },
			[4] = new List<Move>() { new Moves.Payback() },
			[8] = new List<Move>() { new Moves.Headbutt() },
			[12] = new List<Move>() { new Moves.Sandattack() },
			[16] = new List<Move>() { new Moves.Facade() },
			[20] = new List<Move>() { new Moves.Protect() },
			[24] = new List<Move>() { new Moves.Beatup() },
			[28] = new List<Move>() { new Moves.Scaryface() },
			[32] = new List<Move>() { new Moves.Brickbreak() },
			[36] = new List<Move>() { new Moves.Swagger() },
			[40] = new List<Move>() { new Moves.Crunch() },
			[44] = new List<Move>() { new Moves.Highjumpkick() },
			[48] = new List<Move>() { new Moves.Focuspunch() },
			[52] = new List<Move>() { new Moves.Headsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Coaching(), new Moves.Crunch(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Grassknot(), new Moves.Hiddenpower(), new Moves.Icepunch(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Scaryface(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snarl(), new Moves.Snore(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Acidspray(), new Moves.Counter(), new Moves.Detect(), new Moves.Fakeout(), new Moves.Poweruppunch(), new Moves.Quickguard() };
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