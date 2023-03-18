using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Samurott : Pokemon
	{
		public override string Name => "Samurott";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Shellarmor() };
		public override Stats BaseStats => new Stats(95, 100, 85, 108, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Slash() },
			[1] = new List<Move>() { new Slash(), new Megahorn(), new Tackle(), new Tailwhip(), new Watergun(), new Watersport() },
			[5] = new List<Move>() { new Tailwhip() },
			[7] = new List<Move>() { new Watergun() },
			[11] = new List<Move>() { new Watersport() },
			[13] = new List<Move>() { new Focusenergy() },
			[18] = new List<Move>() { new Razorshell() },
			[21] = new List<Move>() { new Furycutter() },
			[25] = new List<Move>() { new Waterpulse() },
			[29] = new List<Move>() { new Revenge() },
			[34] = new List<Move>() { new Aquajet() },
			[39] = new List<Move>() { new Encore() },
			[46] = new List<Move>() { new Aquatail() },
			[51] = new List<Move>() { new Retaliate() },
			[58] = new List<Move>() { new Swordsdance() },
			[63] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Aquatail(), new Attract(), new Blizzard(), new Block(), new Confide(), new Covet(), new Cut(), new Dive(), new Doubleteam(), new Dragontail(), new Facade(), new Falseswipe(), new Fling(), new Frustration(), new Gigaimpact(), new Grassknot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hydrocannon(), new Hyperbeam(), new Icebeam(), new Icywind(), new Irontail(), new Knockoff(), new Liquidation(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Scald(), new Sleeptalk(), new Smartstrike(), new Snore(), new Strength(), new Substitute(), new Superpower(), new Surf(), new Swagger(), new Swordsdance(), new Taunt(), new Toxic(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup(), new Xscissor() };
		public override int Weight => 946;
		public override int ExpYield => 264;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}