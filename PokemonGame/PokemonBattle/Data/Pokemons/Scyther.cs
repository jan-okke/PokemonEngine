using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Scyther : Pokemon
	{
		public override string Name => "Scyther";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Technician() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Steadfast() };
		public override Stats BaseStats => new Stats(70, 110, 80, 105, 55, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quickattack(), new Leer() },
			[4] = new List<Move>() { new Furycutter() },
			[8] = new List<Move>() { new Falseswipe() },
			[12] = new List<Move>() { new Wingattack() },
			[16] = new List<Move>() { new Doubleteam() },
			[20] = new List<Move>() { new Doublehit() },
			[24] = new List<Move>() { new Slash() },
			[28] = new List<Move>() { new Focusenergy() },
			[32] = new List<Move>() { new Agility() },
			[36] = new List<Move>() { new Airslash() },
			[40] = new List<Move>() { new Xscissor() },
			[44] = new List<Move>() { new Laserfocus() },
			[48] = new List<Move>() { new Swordsdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Agility(), new Airslash(), new Assurance(), new Attract(), new Batonpass(), new Brickbreak(), new Brutalswing(), new Bugbuzz(), new Crosspoison(), new Cut(), new Defog(), new Doubleteam(), new Dualwingbeat(), new Endure(), new Facade(), new Falseswipe(), new Focusenergy(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Lightscreen(), new Protect(), new Psychocut(), new Raindance(), new Rest(), new Reversal(), new Rocksmash(), new Roost(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thief(), new Uturn(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Batonpass(), new Counter(), new Feint(), new Nightslash(), new Quickguard(), new Reversal() };
		public override int Weight => 560;
		public override int ExpYield => 100;
		public override int CatchRate => 45;
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