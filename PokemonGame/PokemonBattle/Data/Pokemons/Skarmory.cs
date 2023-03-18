using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Skarmory : Pokemon
	{
		public override string Name => "Skarmory";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Sturdy() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(65, 80, 140, 70, 40, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Leer() },
			[4] = new List<Move>() { new Sandattack() },
			[8] = new List<Move>() { new Furyattack() },
			[12] = new List<Move>() { new Metalclaw() },
			[16] = new List<Move>() { new Agility() },
			[20] = new List<Move>() { new Wingattack() },
			[24] = new List<Move>() { new Slash() },
			[28] = new List<Move>() { new Steelwing() },
			[32] = new List<Move>() { new Autotomize() },
			[36] = new List<Move>() { new Drillpeck() },
			[40] = new List<Move>() { new Metalsound() },
			[44] = new List<Move>() { new Spikes() },
			[48] = new List<Move>() { new Irondefense() },
			[52] = new List<Move>() { new Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Airslash(), new Assurance(), new Attract(), new Bodypress(), new Bravebird(), new Cut(), new Darkpulse(), new Defog(), new Doubleteam(), new Dualwingbeat(), new Endure(), new Facade(), new Flash(), new Flashcannon(), new Fly(), new Guardswap(), new Hiddenpower(), new Icywind(), new Irondefense(), new Ironhead(), new Payback(), new Pluck(), new Protect(), new Rest(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roost(), new Round(), new Sandstorm(), new Sandtomb(), new Sleeptalk(), new Snore(), new Spikes(), new Stealthrock(), new Steelbeam(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Taunt(), new Thief(), new Torment(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Aircutter(), new Assurance(), new Bravebird(), new Curse(), new Drillpeck(), new Feint(), new Guardswap(), new Nightslash(), new Skyattack(), new Whirlwind() };
		public override int Weight => 505;
		public override int ExpYield => 163;
		public override int CatchRate => 25;
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