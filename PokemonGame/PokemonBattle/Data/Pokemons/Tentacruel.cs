using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tentacruel : Pokemon
{
	public override string Name => "Tentacruel";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Clearbody(), new Abilities.Liquidooze() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Raindish() };
	public override Stats BaseStats => new Stats(80, 70, 65, 80, 120, 100);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Poison };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Reflecttype(), new Moves.Poisonsting(), new Moves.Watergun(), new Moves.Acid(), new Moves.Wrap() },
		[12] = new List<Move>() { new Moves.Supersonic() },
		[16] = new List<Move>() { new Moves.Waterpulse() },
		[20] = new List<Move>() { new Moves.Screech() },
		[24] = new List<Move>() { new Moves.Bubblebeam() },
		[28] = new List<Move>() { new Moves.Hex() },
		[34] = new List<Move>() { new Moves.Acidarmor() },
		[40] = new List<Move>() { new Moves.Poisonjab() },
		[46] = new List<Move>() { new Moves.Surf() },
		[52] = new List<Move>() { new Moves.Sludgewave() },
		[58] = new List<Move>() { new Moves.Hydropump() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Brutalswing(), new Moves.Corrosivegas(), new Moves.Crosspoison(), new Moves.Cut(), new Moves.Dazzlinggleam(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Muddywater(), new Moves.Payback(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override int Weight => 550;
	public override int ExpYield => 180;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}