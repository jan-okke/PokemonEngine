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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Ripen(), new Abilities.Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hustle() };
		public override Stats BaseStats => new Stats(70, 110, 80, 95, 60, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Wingattack() },
			[1] = new List<Move>() { new Moves.Wingattack(), new Moves.Recycle(), new Moves.Withdraw(), new Moves.Astonish(), new Moves.Growth(), new Moves.Twister() },
			[4] = new List<Move>() { new Moves.Acidspray() },
			[8] = new List<Move>() { new Moves.Acrobatics() },
			[12] = new List<Move>() { new Moves.Leechseed() },
			[16] = new List<Move>() { new Moves.Protect() },
			[20] = new List<Move>() { new Moves.Dragonbreath() },
			[24] = new List<Move>() { new Moves.Dragondance() },
			[28] = new List<Move>() { new Moves.Dragonpulse() },
			[32] = new List<Move>() { new Moves.Gravapple() },
			[36] = new List<Move>() { new Moves.Irondefense() },
			[40] = new List<Move>() { new Moves.Fly() },
			[44] = new List<Move>() { new Moves.Dragonrush() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Airslash(), new Moves.Attract(), new Moves.Bulletseed(), new Moves.Dracometeor(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fly(), new Moves.Focusenergy(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Outrage(), new Moves.Protect(), new Moves.Rest(), new Moves.Round(), new Moves.Scaryface(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Uturn() };
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