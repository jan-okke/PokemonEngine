using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gliscor : Pokemon
	{
		public override string Name => "Gliscor";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Hypercutter(), new Abilities.Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Poisonheal() };
		public override Stats BaseStats => new Stats(75, 95, 125, 45, 75, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Guillotine(), new Moves.Thunderfang(), new Moves.Icefang(), new Moves.Firefang(), new Moves.Poisonjab(), new Moves.Sandattack(), new Moves.Harden(), new Moves.Knockoff() },
			[4] = new List<Move>() { new Moves.Sandattack() },
			[7] = new List<Move>() { new Moves.Harden() },
			[10] = new List<Move>() { new Moves.Knockoff() },
			[13] = new List<Move>() { new Moves.Quickattack() },
			[16] = new List<Move>() { new Moves.Furycutter() },
			[19] = new List<Move>() { new Moves.Mudslap() },
			[22] = new List<Move>() { new Moves.Acrobatics() },
			[27] = new List<Move>() { new Moves.Nightslash() },
			[30] = new List<Move>() { new Moves.Uturn() },
			[35] = new List<Move>() { new Moves.Screech() },
			[40] = new List<Move>() { new Moves.Xscissor() },
			[45] = new List<Move>() { new Moves.Earthquake() },
			[50] = new List<Move>() { new Moves.Swordsdance() },
			[55] = new List<Move>() { new Moves.Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bugbite(), new Moves.Bulldoze(), new Moves.Confide(), new Moves.Cut(), new Moves.Darkpulse(), new Moves.Defog(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roost(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Skyattack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelwing(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Strugglebug(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Tailwind(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Torment(), new Moves.Uturn(), new Moves.Venoshock(), new Moves.Xscissor() };
		public override int Weight => 425;
		public override int ExpYield => 179;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}