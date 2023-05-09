using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Farfetchd : Pokemon
{
	public override string Name => "Farfetch'd";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Keeneye(), new Abilities.Innerfocus() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Defiant() };
	public override Stats BaseStats => new Stats(52, 90, 55, 58, 62, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Peck(), new Moves.Sandattack() },
		[5] = new List<Move>() { new Moves.Leer() },
		[10] = new List<Move>() { new Moves.Furycutter() },
		[15] = new List<Move>() { new Moves.Cut() },
		[20] = new List<Move>() { new Moves.Aerialace() },
		[25] = new List<Move>() { new Moves.Aircutter() },
		[30] = new List<Move>() { new Moves.Knockoff() },
		[35] = new List<Move>() { new Moves.Falseswipe() },
		[40] = new List<Move>() { new Moves.Slash() },
		[45] = new List<Move>() { new Moves.Swordsdance() },
		[50] = new List<Move>() { new Moves.Airslash() },
		[55] = new List<Move>() { new Moves.Leafblade() },
		[60] = new List<Move>() { new Moves.Agility() },
		[65] = new List<Move>() { new Moves.Bravebird() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Bravebird(), new Moves.Brutalswing(), new Moves.Closecombat(), new Moves.Cut(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fly(), new Moves.Focusenergy(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Leafblade(), new Moves.Pluck(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Psychup(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Roost(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarblade(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Covet(), new Moves.Curse(), new Moves.Featherdance(), new Moves.Feint(), new Moves.Finalgambit(), new Moves.Flail(), new Moves.Gust(), new Moves.Leafblade(), new Moves.Mudslap(), new Moves.Nightslash(), new Moves.Quickattack(), new Moves.Revenge(), new Moves.Simplebeam(), new Moves.Skyattack() };
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