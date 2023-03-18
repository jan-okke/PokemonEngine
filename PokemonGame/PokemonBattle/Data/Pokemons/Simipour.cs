using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Simipour : Pokemon
	{
		public override string Name => "Simipour";
		public override List<Ability> AvailableAbilities => new() {new Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Torrent() };
		public override Stats BaseStats => new Stats(75, 98, 63, 98, 63, 101);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Leer(), new Lick(), new Furyswipes(), new Scald() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aquatail(), new Attract(), new Blizzard(), new Brickbreak(), new Confide(), new Covet(), new Cut(), new Dive(), new Doubleteam(), new Endeavor(), new Facade(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gastroacid(), new Gigaimpact(), new Grassknot(), new Gunkshot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Knockoff(), new Lowkick(), new Lowsweep(), new Payback(), new Poweruppunch(), new Protect(), new Raindance(), new Recycle(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Scald(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Taunt(), new Thief(), new Throatchop(), new Torment(), new Toxic(), new Uproar(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup() };
		public override int Weight => 290;
		public override int ExpYield => 174;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}