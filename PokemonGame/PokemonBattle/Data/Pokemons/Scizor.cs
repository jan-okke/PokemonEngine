using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Scizor : Pokemon
	{
		public override string Name => "Scizor";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Technician() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Lightmetal() };
		public override Stats BaseStats => new Stats(70, 130, 100, 65, 55, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Bulletpunch() },
			[1] = new List<Move>() { new Bulletpunch(), new Wingattack(), new Agility(), new Airslash(), new Quickattack(), new Leer(), new Furycutter(), new Falseswipe() },
			[12] = new List<Move>() { new Metalclaw() },
			[16] = new List<Move>() { new Doubleteam() },
			[20] = new List<Move>() { new Doublehit() },
			[24] = new List<Move>() { new Slash() },
			[28] = new List<Move>() { new Focusenergy() },
			[32] = new List<Move>() { new Irondefense() },
			[36] = new List<Move>() { new Ironhead() },
			[40] = new List<Move>() { new Xscissor() },
			[44] = new List<Move>() { new Laserfocus() },
			[48] = new List<Move>() { new Swordsdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Agility(), new Airslash(), new Assurance(), new Attract(), new Batonpass(), new Brickbreak(), new Brutalswing(), new Bugbuzz(), new Crosspoison(), new Cut(), new Defog(), new Doubleteam(), new Dualwingbeat(), new Endure(), new Facade(), new Falseswipe(), new Flashcannon(), new Fling(), new Focusenergy(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Lightscreen(), new Protect(), new Psychocut(), new Raindance(), new Rest(), new Reversal(), new Rocksmash(), new Roost(), new Round(), new Safeguard(), new Sandstorm(), new Sandtomb(), new Sleeptalk(), new Snore(), new Steelbeam(), new Steelwing(), new Strength(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Swift(), new Swordsdance(), new Thief(), new Uturn(), new Venoshock(), new Xscissor() };
		public override int Weight => 1180;
		public override int ExpYield => 175;
		public override int CatchRate => 25;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}