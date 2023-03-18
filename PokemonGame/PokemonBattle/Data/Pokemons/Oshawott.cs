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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Shellarmor() };
		public override Stats BaseStats => new Stats(55, 55, 45, 63, 45, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle() },
			[5] = new List<Move>() { new Moves.Tailwhip() },
			[7] = new List<Move>() { new Moves.Watergun() },
			[11] = new List<Move>() { new Moves.Watersport() },
			[13] = new List<Move>() { new Moves.Focusenergy() },
			[17] = new List<Move>() { new Moves.Razorshell() },
			[19] = new List<Move>() { new Moves.Furycutter() },
			[23] = new List<Move>() { new Moves.Waterpulse() },
			[25] = new List<Move>() { new Moves.Revenge() },
			[29] = new List<Move>() { new Moves.Aquajet() },
			[31] = new List<Move>() { new Moves.Encore() },
			[35] = new List<Move>() { new Moves.Aquatail() },
			[37] = new List<Move>() { new Moves.Retaliate() },
			[41] = new List<Move>() { new Moves.Swordsdance() },
			[43] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Frustration(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Toxic(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Waterpulse(), new Moves.Workup(), new Moves.Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Airslash(), new Moves.Assurance(), new Moves.Brine(), new Moves.Copycat(), new Moves.Detect(), new Moves.Nightslash(), new Moves.Sacredsword(), new Moves.Screech(), new Moves.Trumpcard() };
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