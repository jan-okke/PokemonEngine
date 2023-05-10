using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Indeedee : Pokemon
{
	public override string Name => "Indeedee";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Innerfocus(), new Abilities.Synchronize() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Psychicsurge() };
	public override Stats BaseStats => new Stats(60, 65, 55, 105, 95, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Storedpower(), new Moves.Playnice() },
		[5] = new List<Move>() { new Moves.Encore() },
		[10] = new List<Move>() { new Moves.Disarmingvoice() },
		[15] = new List<Move>() { new Moves.Psybeam() },
		[20] = new List<Move>() { new Moves.Helpinghand() },
		[25] = new List<Move>() { new Moves.Afteryou() },
		[30] = new List<Move>() { new Moves.Aromatherapy() },
		[35] = new List<Move>() { new Moves.Psychic() },
		[40] = new List<Move>() { new Moves.Calmmind() },
		[45] = new List<Move>() { new Moves.Powersplit() },
		[50] = new List<Move>() { new Moves.Psychicterrain() },
		[55] = new List<Move>() { new Moves.Lastresort() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Futuresight(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Imprison(), new Moves.Magicalleaf(), new Moves.Magicroom(), new Moves.Metronome(), new Moves.Mysticalfire(), new Moves.Payday(), new Moves.Playrough(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psyshock(), new Moves.Rest(), new Moves.Round(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Swift(), new Moves.Terrainpulse(), new Moves.Triattack(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Extrasensory(), new Moves.Fakeout(), new Moves.Psychup() };
	public override int Weight => 280;
	public override int ExpYield => 166;
	public override int CatchRate => 30;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}