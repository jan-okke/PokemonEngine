using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Regidrago : Pokemon
	{
		public override string Name => "Regidrago";
		public override List<Ability> AvailableAbilities => new() {new Dragonsmaw() };
		public override Stats BaseStats => new Stats(200, 100, 50, 80, 100, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Twister(), new Visegrip() },
			[6] = new List<Move>() { new Bite() },
			[12] = new List<Move>() { new Ancientpower() },
			[18] = new List<Move>() { new Dragonbreath() },
			[24] = new List<Move>() { new Focusenergy() },
			[30] = new List<Move>() { new Crunch() },
			[36] = new List<Move>() { new Dragonclaw() },
			[42] = new List<Move>() { new Hammerarm() },
			[48] = new List<Move>() { new Dragondance() },
			[54] = new List<Move>() { new Thrash() },
			[60] = new List<Move>() { new Laserfocus() },
			[66] = new List<Move>() { new Dragonenergy() },
			[72] = new List<Move>() { new Hyperbeam() },
			[78] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bodyslam(), new Breakingswipe(), new Crunch(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Endure(), new Facade(), new Firefang(), new Focusenergy(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Lightscreen(), new Outrage(), new Protect(), new Reflect(), new Rest(), new Reversal(), new Round(), new Scaleshot(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Substitute(), new Thunderfang() };
		public override int Weight => 2000;
		public override int ExpYield => 290;
		public override int CatchRate => 3;
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