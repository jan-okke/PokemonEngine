using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Regidrago : Pokemon
{
	public override string Name => "Regidrago";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Dragonsmaw() };
	public override Stats BaseStats => new Stats(200, 100, 50, 100, 50, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Twister(), new Moves.Visegrip() },
		[6] = new List<Move>() { new Moves.Bite() },
		[12] = new List<Move>() { new Moves.Ancientpower() },
		[18] = new List<Move>() { new Moves.Dragonbreath() },
		[24] = new List<Move>() { new Moves.Focusenergy() },
		[30] = new List<Move>() { new Moves.Crunch() },
		[36] = new List<Move>() { new Moves.Dragonclaw() },
		[42] = new List<Move>() { new Moves.Hammerarm() },
		[48] = new List<Move>() { new Moves.Dragondance() },
		[54] = new List<Move>() { new Moves.Thrash() },
		[60] = new List<Move>() { new Moves.Laserfocus() },
		[66] = new List<Move>() { new Moves.Dragonenergy() },
		[72] = new List<Move>() { new Moves.Hyperbeam() },
		[78] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Crunch(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Lightscreen(), new Moves.Outrage(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Round(), new Moves.Scaleshot(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Thunderfang() };
	public override int Weight => 2000;
	public override int ExpYield => 290;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}