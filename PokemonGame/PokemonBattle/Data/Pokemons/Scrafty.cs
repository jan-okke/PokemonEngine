using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Scrafty : Pokemon
	{
		public override string Name => "Scrafty";
		public override List<Ability> AvailableAbilities => new() {new Shedskin(), new Moxie() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Intimidate() };
		public override Stats BaseStats => new Stats(65, 90, 115, 58, 45, 115);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Dark, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Lowkick(), new Leer(), new Payback(), new Headbutt() },
			[12] = new List<Move>() { new Sandattack() },
			[16] = new List<Move>() { new Facade() },
			[20] = new List<Move>() { new Protect() },
			[24] = new List<Move>() { new Beatup() },
			[28] = new List<Move>() { new Scaryface() },
			[32] = new List<Move>() { new Brickbreak() },
			[36] = new List<Move>() { new Swagger() },
			[42] = new List<Move>() { new Crunch() },
			[48] = new List<Move>() { new Highjumpkick() },
			[54] = new List<Move>() { new Focuspunch() },
			[60] = new List<Move>() { new Headsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Assurance(), new Attract(), new Beatup(), new Brickbreak(), new Bulkup(), new Closecombat(), new Coaching(), new Crunch(), new Darkpulse(), new Dig(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Drainpunch(), new Endure(), new Facade(), new Faketears(), new Firepunch(), new Fling(), new Focusblast(), new Foulplay(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Irondefense(), new Ironhead(), new Irontail(), new Lashout(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Outrage(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Retaliate(), new Revenge(), new Rockslide(), new Rocktomb(), new Round(), new Scaryface(), new Sleeptalk(), new Sludgebomb(), new Snarl(), new Snore(), new Stoneedge(), new Substitute(), new Sunnyday(), new Taunt(), new Thief(), new Throatchop(), new Thunderpunch(), new Workup(), new Zenheadbutt() };
		public override int Weight => 300;
		public override int ExpYield => 171;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}