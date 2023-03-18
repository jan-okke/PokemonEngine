using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Flapple : Pokemon
	{
		public override string Name => "Flapple";
		public override List<Ability> AvailableAbilities => new() {new Ripen(), new Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hustle() };
		public override Stats BaseStats => new Stats(70, 110, 80, 95, 60, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Wingattack() },
			[1] = new List<Move>() { new Wingattack(), new Recycle(), new Withdraw(), new Astonish(), new Growth(), new Twister() },
			[4] = new List<Move>() { new Acidspray() },
			[8] = new List<Move>() { new Acrobatics() },
			[12] = new List<Move>() { new Leechseed() },
			[16] = new List<Move>() { new Protect() },
			[20] = new List<Move>() { new Dragonbreath() },
			[24] = new List<Move>() { new Dragondance() },
			[28] = new List<Move>() { new Dragonpulse() },
			[32] = new List<Move>() { new Gravapple() },
			[36] = new List<Move>() { new Irondefense() },
			[40] = new List<Move>() { new Fly() },
			[44] = new List<Move>() { new Dragonrush() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Airslash(), new Attract(), new Bulletseed(), new Dracometeor(), new Dragondance(), new Dragonpulse(), new Dualwingbeat(), new Endure(), new Energyball(), new Facade(), new Fly(), new Focusenergy(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Outrage(), new Protect(), new Rest(), new Round(), new Scaryface(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Uturn() };
		public override int Weight => 10;
		public override int ExpYield => 170;
		public override int CatchRate => 45;
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