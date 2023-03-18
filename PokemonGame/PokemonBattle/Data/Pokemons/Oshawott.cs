using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Oshawott : Pokemon
	{
		public override string Name => "Oshawott";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Shellarmor() };
		public override Stats BaseStats => new Stats(55, 55, 45, 45, 63, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[5] = new List<Move>() { new Tailwhip() },
			[7] = new List<Move>() { new Watergun() },
			[11] = new List<Move>() { new Watersport() },
			[13] = new List<Move>() { new Focusenergy() },
			[17] = new List<Move>() { new Razorshell() },
			[19] = new List<Move>() { new Furycutter() },
			[23] = new List<Move>() { new Waterpulse() },
			[25] = new List<Move>() { new Revenge() },
			[29] = new List<Move>() { new Aquajet() },
			[31] = new List<Move>() { new Encore() },
			[35] = new List<Move>() { new Aquatail() },
			[37] = new List<Move>() { new Retaliate() },
			[41] = new List<Move>() { new Swordsdance() },
			[43] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Aquatail(), new Attract(), new Blizzard(), new Confide(), new Covet(), new Cut(), new Dive(), new Doubleteam(), new Facade(), new Falseswipe(), new Fling(), new Frustration(), new Grassknot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irontail(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swordsdance(), new Taunt(), new Toxic(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Airslash(), new Assurance(), new Brine(), new Copycat(), new Detect(), new Nightslash(), new Sacredsword(), new Screech(), new Trumpcard() };
		public override int Weight => 59;
		public override int ExpYield => 62;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}