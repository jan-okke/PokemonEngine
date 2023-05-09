using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Clawitzer : Pokemon
{
	public override string Name => "Clawitzer";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Megalauncher() };
	public override Stats BaseStats => new Stats(71, 73, 88, 120, 89, 59);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Darkpulse(), new Moves.Dragonpulse(), new Moves.Healpulse(), new Moves.Splash(), new Moves.Watergun(), new Moves.Visegrip(), new Moves.Flail() },
		[15] = new List<Move>() { new Moves.Aquajet() },
		[20] = new List<Move>() { new Moves.Smackdown() },
		[25] = new List<Move>() { new Moves.Honeclaws() },
		[30] = new List<Move>() { new Moves.Waterpulse() },
		[35] = new List<Move>() { new Moves.Swordsdance() },
		[42] = new List<Move>() { new Moves.Aurasphere() },
		[49] = new List<Move>() { new Moves.Bounce() },
		[56] = new List<Move>() { new Moves.Muddywater() },
		[63] = new List<Move>() { new Moves.Crabhammer() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Aurasphere(), new Moves.Bounce(), new Moves.Darkpulse(), new Moves.Dive(), new Moves.Dragonpulse(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Flipturn(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Liquidation(), new Moves.Muddywater(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swordsdance(), new Moves.Terrainpulse(), new Moves.Uturn(), new Moves.Venoshock(), new Moves.Waterfall() };
	public override int Weight => 353;
	public override int ExpYield => 100;
	public override int CatchRate => 55;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}