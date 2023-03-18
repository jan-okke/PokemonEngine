using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Eternatus : Pokemon
	{
		public override string Name => "Eternatus";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override Stats BaseStats => new Stats(140, 85, 95, 130, 145, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Poisontail(), new Confuseray(), new Dragontail(), new Agility() },
			[8] = new List<Move>() { new Toxic() },
			[16] = new List<Move>() { new Venoshock() },
			[24] = new List<Move>() { new Dragondance() },
			[32] = new List<Move>() { new Crosspoison() },
			[40] = new List<Move>() { new Dragonpulse() },
			[48] = new List<Move>() { new Flamethrower() },
			[56] = new List<Move>() { new Dynamaxcannon() },
			[64] = new List<Move>() { new Cosmicpower() },
			[72] = new List<Move>() { new Recover() },
			[80] = new List<Move>() { new Hyperbeam() },
			[88] = new List<Move>() { new Eternabeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Agility(), new Assurance(), new Brutalswing(), new Cosmicpower(), new Crosspoison(), new Dracometeor(), new Dragondance(), new Dragonpulse(), new Endure(), new Facade(), new Flamethrower(), new Flashcannon(), new Fly(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Lightscreen(), new Meteorbeam(), new Mysticalfire(), new Payback(), new Poisonjab(), new Protect(), new Reflect(), new Rest(), new Round(), new Scaryface(), new Screech(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Solarbeam(), new Substitute(), new Toxicspikes(), new Venomdrench(), new Venoshock() };
		public override int Weight => 9500;
		public override int ExpYield => 345;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}