using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Escavalier : Pokemon
	{
		public override string Name => "Escavalier";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(70, 135, 105, 60, 105, 20);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Fellstinger(), new Endure(), new Flail(), new Scaryface(), new Takedown(), new Doubleedge(), new Peck(), new Leer(), new Furycutter(), new Quickguard() },
			[12] = new List<Move>() { new Falseswipe() },
			[16] = new List<Move>() { new Acidspray() },
			[20] = new List<Move>() { new Headbutt() },
			[24] = new List<Move>() { new Reversal() },
			[28] = new List<Move>() { new Irondefense() },
			[32] = new List<Move>() { new Xscissor() },
			[36] = new List<Move>() { new Swordsdance() },
			[40] = new List<Move>() { new Ironhead() },
			[44] = new List<Move>() { new Bugbuzz() },
			[48] = new List<Move>() { new Gigaimpact() },
			[52] = new List<Move>() { new Metalburst() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Attract(), new Brutalswing(), new Bugbuzz(), new Closecombat(), new Drillrun(), new Encore(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Focusblast(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Megahorn(), new Poisonjab(), new Protect(), new Raindance(), new Razorshell(), new Rest(), new Revenge(), new Reversal(), new Round(), new Scaryface(), new Screech(), new Sleeptalk(), new Smartstrike(), new Snore(), new Steelbeam(), new Substitute(), new Swordsdance(), new Taunt(), new Xscissor() };
		public override int Weight => 330;
		public override int ExpYield => 173;
		public override int CatchRate => 75;
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