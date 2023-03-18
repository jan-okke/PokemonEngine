using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Farfetch'd : Pokemon
	{
		public override string Name => "Farfetch'd";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Innerfocus() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Defiant() };
		public override Stats BaseStats => new Stats(52, 90, 55, 58, 62, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Sandattack() },
			[5] = new List<Move>() { new Leer() },
			[10] = new List<Move>() { new Furycutter() },
			[15] = new List<Move>() { new Cut() },
			[20] = new List<Move>() { new Aerialace() },
			[25] = new List<Move>() { new Aircutter() },
			[30] = new List<Move>() { new Knockoff() },
			[35] = new List<Move>() { new Falseswipe() },
			[40] = new List<Move>() { new Slash() },
			[45] = new List<Move>() { new Swordsdance() },
			[50] = new List<Move>() { new Airslash() },
			[55] = new List<Move>() { new Leafblade() },
			[60] = new List<Move>() { new Agility() },
			[65] = new List<Move>() { new Bravebird() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Agility(), new Airslash(), new Attract(), new Batonpass(), new Bodyslam(), new Bravebird(), new Brutalswing(), new Closecombat(), new Cut(), new Defog(), new Doubleteam(), new Dualwingbeat(), new Endure(), new Facade(), new Falseswipe(), new Fly(), new Focusenergy(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Leafblade(), new Pluck(), new Poisonjab(), new Protect(), new Psychup(), new Rest(), new Retaliate(), new Revenge(), new Roost(), new Round(), new Sleeptalk(), new Snore(), new Solarblade(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thief(), new Throatchop(), new Uproar(), new Uturn(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Covet(), new Curse(), new Featherdance(), new Feint(), new Finalgambit(), new Flail(), new Gust(), new Leafblade(), new Mudslap(), new Nightslash(), new Quickattack(), new Revenge(), new Simplebeam(), new Skyattack() };
		public override int Weight => 150;
		public override int ExpYield => 132;
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