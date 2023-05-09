using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Octillery : Pokemon
{
	public override string Name => "Octillery";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Suctioncups(), new Abilities.Sniper() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moody() };
	public override Stats BaseStats => new Stats(75, 105, 75, 105, 75, 45);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Water };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Octazooka() },
		[1] = new List<Move>() { new Moves.Octazooka(), new Moves.Gunkshot(), new Moves.Rockblast(), new Moves.Helpinghand(), new Moves.Watergun(), new Moves.Wrap(), new Moves.Waterpulse(), new Moves.Focusenergy() },
		[12] = new List<Move>() { new Moves.Psybeam() },
		[16] = new List<Move>() { new Moves.Aurorabeam() },
		[20] = new List<Move>() { new Moves.Bubblebeam() },
		[24] = new List<Move>() { new Moves.Lockon() },
		[30] = new List<Move>() { new Moves.Bulletseed() },
		[36] = new List<Move>() { new Moves.Icebeam() },
		[42] = new List<Move>() { new Moves.Hydropump() },
		[48] = new List<Move>() { new Moves.Soak() },
		[54] = new List<Move>() { new Moves.Hyperbeam() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bounce(), new Moves.Brine(), new Moves.Bulletseed(), new Moves.Chargebeam(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Liquidation(), new Moves.Mudshot(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Round(), new Moves.Scald(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool() };
	public override int Weight => 285;
	public override int ExpYield => 168;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 1,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 1,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}